import React, { useEffect, useState } from 'react';
import InfoOutlinedIcon from '@mui/icons-material/InfoOutlined';
import './TestingPage.scss';
import { Block } from '../../components/Block/Block';
import { BLOCK_TITLES } from '../../common/enums/block-titles';
import { Input } from '../../components/Input/Input';
import { Button } from '../../components/Button/Button';
import { BUTTON_TYPES } from '../../common/enums/button-types';
import { Success } from '../../components/Success/Success';
import { Error } from '../../components/Error/Error';
import { Recommendation } from '../../components/Recommendation/Recommendation';
import { Auth } from '../../api/auth';
import { apiFetchGet } from '../../api/fetch';
import { TestWithQuestions } from '../../common/types/test-with-questions';
import { Variant } from '../../common/types/variant';

export const TestingPage: React.FC = () => {
  const [currentQuestion, setCurrentQuestion] = useState(0);
  const [currentTest, setCurrentTest] = useState(0);

  const [showScore, setShowScore] = useState(false);

  const [isSubmitting, setIsSubmitting] = useState(false);
  const [success, setSuccess] = useState(false);
  const [error, setError] = useState(false);

  const [isInProgress, setIsInProgress] = useState(false);
  const [tests, setTests] = useState<TestWithQuestions[]>([]);
  const [chosenVariants, setChosenVariants] = useState<Variant[]>([]);

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    setIsSubmitting(true);
    event.preventDefault();
    const random = Math.round(Math.random());
    setTimeout(() => {
      random ? setSuccess(true) : setError(true);
      setIsSubmitting(false);
    }, 2000);
  };

  useEffect(() => {
    apiFetchGet('/api/Test/all/with-questions')
      .then<TestWithQuestions[]>((response) => response.json())
      .then((tests) => setTests(tests))
      .catch((error) => alert('/api/Test/all/with-questions' + error));
  }, []);

  useEffect(() => {
    if (error) setTimeout(() => setError(false), 3000);
  }, [error]);

  const handleVariantClick = (variant: Variant) => {
    const questions = tests[currentTest]?.questions;
    const nextQuestion = currentQuestion + 1;

    if (!isInProgress) setIsInProgress(true);
    setChosenVariants([...chosenVariants, variant]);

    if (nextQuestion < questions.length) {
      setCurrentQuestion(nextQuestion);
    } else {
      setIsSubmitting(true);
      setTimeout(() => {
        setShowScore(true);
        setIsSubmitting(false);
      }, 2000);
    }
  };

  const nextTest = () => {
    if (currentTest + 1 < tests.length) {
      setCurrentTest(currentTest + 1);
    } else {
      setCurrentTest(0);
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
                <Recommendation /> :
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
                <li>
                  Sadness and/or a loss of
                  interest in activities: { }
                </li>
                <li>
                  Disorders of sense and motion: { }
                </li>
                <li>
                  Intense, persistent fear of being watched
                  and judged by others: { }
                </li>
                <li>
                  Generalized weakness and
                  usually involving mental
                  and physical fatigue: { }
                </li>
                <li>
                  Sleep disorder: { }
                </li>
              </ul>
              <div className="sending-container">
                {success ?
                  <Success /> :
                  error ?
                    <Error /> :
                    <form onSubmit={(e) => handleSubmit(e)}>
                      {
                        Auth.isLogged() ?
                          <p>
                            {
                              `You can send your results to our specialist.
                              He will analyze that and will send
                              an answer to your e-mail`
                            }.
                          </p> :
                          <>
                            <Input label={'Name'}></Input>
                            <Input label={'E-mail'}></Input>
                          </>
                      }

                      <Button
                        title={isSubmitting ? 'sending...' : 'send'}
                        type={BUTTON_TYPES.DEFAULT}
                        submitting={isSubmitting}
                      />
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
