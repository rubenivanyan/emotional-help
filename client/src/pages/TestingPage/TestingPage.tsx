import React, { useEffect, useState } from 'react';
import InfoOutlinedIcon from '@mui/icons-material/InfoOutlined';
import './TestingPage.scss';
import { Block } from '../../components/Block/Block';
import { BLOCK_TITLES } from '../../common/enums/block-titles';
import { Button } from '../../components/Button/Button';
import { BUTTON_TYPES } from '../../common/enums/button-types';
import { Success } from '../../components/Success/Success';
import { Error } from '../../components/Error/Error';
import { Recommendation } from '../../components/Recommendation/Recommendation';
import { apiFetchGet, apiFetchPost } from '../../api/fetch/fetch';
import { TestWithQuestions } from '../../common/types/test-with-questions';
import { Variant } from '../../common/types/variant';
import { TestResults } from '../../common/types/test-results';
import { TestingApplication } from '../../common/types/testing-application';
import { sendApplication } from '../../api/fetch/applications';
import { Auth } from '../../api/auth';
import {
  QuestionWithVariants,
} from '../../common/types/question-with-variants';
import { TestResultsValues } from '../../common/types/test-results-values';

export const TestingPage: React.FC = () => {
  const [currentQuestion, setCurrentQuestion] = useState(0);
  const [currentTest, setCurrentTest] = useState(0);

  const [showScore, setShowScore] = useState(false);

  const [isSubmitting, setIsSubmitting] = useState(false);
  const [success, setSuccess] = useState(false);
  const [error, setError] = useState(false);

  const [isInProgress, setIsInProgress] = useState(false);
  const [isTestFinished, setIsTestFinished] = useState(false);
  const [tests, setTests] = useState<TestWithQuestions[]>([]);
  const [chosenVariants, setChosenVariants] = useState<Variant[]>([]);
  const [
    answeredQuestions,
    setAnsweredQuestions,
  ] = useState<QuestionWithVariants[]>([]);
  const [recommendations, setRecommendations] = useState({});
  const [results, setResults] = useState<TestResultsValues>();

  const [testResultId, setTestResultId] = useState<number | null>(null);

  const testResults: TestResults = {
    testId: tests[currentTest]?.id,
    chosenVariants: chosenVariants,
    questions: answeredQuestions,
  };

  const testingApplication: TestingApplication = {
    isArchived: false,
    testResultsId: testResultId,
  };

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    event.preventDefault();
    setIsSubmitting(true);

    sendApplication(
      '/api/TestingApplication',
      testingApplication,
      setSuccess,
      setError,
      setIsSubmitting,
    );
  };

  useEffect(() => {
    apiFetchGet('/api/Test/all/with-questions')
      .then<TestWithQuestions[]>((response) => response.json())
      .then((tests) => setTests(tests))
      .catch((error) => alert('/api/Test/all/with-questions' + error));
  }, []);

  useEffect(() => {
    if (isTestFinished) {
      const path = Auth.isLogged() ?
        '/api/TestResult' :
        '/api/TestResult/unauthorized';

      apiFetchPost(path, testResults)
        .then<TestResults>((response) => response.json())
        .then((response) => {
          console.log(response);
          setRecommendations({
            books: response.materialsRecommendations.books,
            computerGames: response.materialsRecommendations.computerGames,
            films: response.materialsRecommendations.films,
            music: response.materialsRecommendations.music,
          });
          setResults({
            neurosis: response.questionGroupsValues[0].value,
            socialAnxiety: response.questionGroupsValues[1].value,
            depression: response.questionGroupsValues[2].value,
            asthenia: response.questionGroupsValues[3].value,
          });
          setTestResultId(response.id);
        })
        .catch((error) => alert(path + error));
    }
  }, [isTestFinished]);

  useEffect(() => {
    if (error) setTimeout(() => setError(false), 3000);
  }, [error]);

  const nextTest = () => {
    if (currentTest + 1 < tests.length) {
      setCurrentTest(currentTest + 1);
    } else {
      setCurrentTest(0);
    }
  };

  const handleVariantClick = (variant: Variant) => {
    const questions = tests[currentTest]?.questions;
    const nextQuestion = currentQuestion + 1;

    setAnsweredQuestions([
      ...answeredQuestions,
      {
        formulation: questions[currentQuestion].formulation,
        questionGroup: questions[currentQuestion].questionGroup,
      },
    ]);

    if (!isInProgress) setIsInProgress(true);
    setChosenVariants([...chosenVariants, variant]);

    if (nextQuestion < questions.length) {
      setCurrentQuestion(nextQuestion);
    } else {
      setIsTestFinished(true);
      setIsSubmitting(true);
      setTimeout(() => {
        setShowScore(true);
        setIsSubmitting(false);
      }, 2000);
    }
  };

  return (
    <section
      className={
        'testing-container' +
        (isSubmitting && !showScore ? ' sending' : '')
      }>
      <Block title={BLOCK_TITLES.TESTING} percentWidth={100}>
        <head className="quiz-info">
          <InfoOutlinedIcon fontSize="large" color="info" />
          <div className="quiz-info-text">
            {
              showScore ?
                <Recommendation {...recommendations} /> :
                <>
                  <p>
                    This test will help you to understand
                    your emotional state.
                    The test does not allow diagnosis,
                    nor does it provide medical evaluations.
                    A psychiatrist or clinical psychologist should be
                    consulted to obtain an appropriate assessment.
                  </p>
                  <h2>{`Test: ${tests[currentTest]?.title}`}</h2>
                  {!isInProgress ?
                    <div className="testing-buttons">
                      <Button
                        title={'next'}
                        type={BUTTON_TYPES.DEFAULT}
                        onClick={() => nextTest()} />
                      <Button
                        title={'start'}
                        type={BUTTON_TYPES.GREEN}
                        onClick={() => setIsInProgress(true)} />
                    </div> :
                    <p>
                      The test has been started
                    </p>
                  }
                </>
            }
          </div>
        </head>
        <section className="question-container">
          {showScore ? (
            <div className="score-section">
              <ul className="score-list">
                Your results:
                {
                  results ?
                    <>
                      <li>
                        Sadness and/or a loss of
                        interest in activities: {results.depression}
                      </li>
                      <li>
                        Disorders of sense and motion: {results.neurosis}
                      </li>
                      <li>
                        Intense, persistent fear of being watched
                        and judged by others: {results.socialAnxiety}
                      </li>
                      <li>
                        Generalized weakness and
                        usually involving mental
                        and physical fatigue: {results.asthenia}
                      </li>
                    </> :
                    <h3>Loading results...</h3>
                }
              </ul>
              <div className="sending-container">
                {success ?
                  <Success /> :
                  error ?
                    <Error /> :
                    <form onSubmit={(e) => handleSubmit(e)}>
                      {
                        Auth.isLogged() ?
                          <>
                            <p>
                              {
                                `You can send your results to our specialist.
                              He will analyze that and will send
                              an answer to your e-mail`
                              }.
                            </p>
                            <Button
                              title={isSubmitting ? 'sending...' : 'send'}
                              type={BUTTON_TYPES.DEFAULT}
                              submitting={isSubmitting}
                            />
                          </> :
                          <>
                            <p>
                              {
                                `Only authenticated users
                                can send result to ours specialist`
                              }
                            </p>
                            <a className="button" href="/sign-in">SIGN IN</a>
                            <a className="button" href="/sign-up">SIGN UP</a>
                          </>
                      }
                    </form>
                }
              </div>
              <div className="link-container">
                <a className="button" href="/training">Join training</a>
                <a className="button" href="/consulting">Order consulting</a>
              </div>
            </div>
          ) : (
            <>
              <section className="question-section">
                <div className="question-count">
                  <span>
                    Question {currentQuestion + 1}
                  </span>
                  /
                  {tests[currentTest]?.questions.length}
                </div>
                <p className="question-text">
                  {tests[currentTest]?.questions[currentQuestion]?.formulation}
                </p>
              </section>
              <section className="answer-section">
                {tests[currentTest]?.questions[currentQuestion]?.variants
                  .map((variant) => (
                    <button
                      className="answer-button"
                      key={variant.formulation}
                      onClick={() =>
                        handleVariantClick(variant)}
                    >
                      {variant.formulation}
                    </button>
                  ))}
              </section>
            </>
          )}
        </section>
      </Block >
    </section >
  );
};
