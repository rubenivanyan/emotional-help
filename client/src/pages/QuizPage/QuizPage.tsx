import React, { useState } from 'react';
import InfoOutlinedIcon from '@mui/icons-material/InfoOutlined';
import './QuizPage.scss';

export const Quiz: React.FC = () => {
  const answerOptions = [
    { answerText: '😀 Not at all', value: 0 },
    { answerText: '🙂 Rarely', value: 1 },
    { answerText: '😐 Sometimes', value: 2 },
    { answerText: '🙁 Often', value: 3 },
    { answerText: '😢 Constantly', value: 4 },
  ];
  const questions = [
    {
      questionText: 'Do you feel your mood is decreased?',
      questionGroup: 'Depression',
    },
    {
      questionText: 'You feel the loss of interest',
      questionGroup: 'Depression',
    },
    {
      questionText: 'You have feelings of inferiority',
      questionGroup: 'Depression',
    },
    {
      questionText: 'Sometimes you blame yourself',
      questionGroup: 'Depression',
    },
    {
      questionText: 'You have recurring thoughts of death, or suicide',
      questionGroup: 'Depression',
    },
    {
      questionText: 'Do you feel lonely?',
      questionGroup: 'Depression',
    },
    {
      questionText: 'Do you feel hopelessness in relation to the future?',
      questionGroup: 'Depression',
    },
    {
      questionText: 'You are unable to feel joy',
      questionGroup: 'Depression',
    },
    {
      questionText: 'You get irritable or angry rapidly',
      questionGroup: 'Neurosis',
    },
    {
      questionText: 'You feel anxious or fearful',
      questionGroup: 'Neurosis',
    },
    {
      questionText: 'You feel tension or inability to relax',
      questionGroup: 'Neurosis',
    },
    {
      questionText: 'You have excessive preoccupation for various reasons',
      questionGroup: 'Neurosis',
    },
    {
      questionText: 'You feel anxiety or fussiness, inability to sit still',
      questionGroup: 'Neurosis',
    },
    {
      questionText: 'You feel light fearfulness',
      questionGroup: 'Neurosis',
    },
    {
      questionText: 'You have fear of being in the spotlight',
      questionGroup: 'Social anxiety',
    },
    {
      questionText: 'You feel fear when dealing with strangers',
      questionGroup: 'Social anxiety',
    },
    {
      questionText: 'How often do you feel sluggish or tired?',
      questionGroup: 'Asthenia',
    },
    {
      questionText: 'How often your ability to focus is decreased?',
      questionGroup: 'Asthenia',
    },
    {
      // eslint-disable-next-line
      questionText: "You can't regain your strength even after good rest",
      questionGroup: 'Asthenia',
    },
    {
      questionText: 'You experiencing fatigue',
      questionGroup: 'Asthenia',
    },
    {
      questionText: 'You have difficulties with falling asleep',
      questionGroup: 'Insomnia',
    },
    {
      questionText: 'You have troubled or intermittent sleep',
      questionGroup: 'Insomnia',
    },
    {
      questionText: 'You wake up too early',
      questionGroup: 'Insomnia',
    },
  ];

  const [currentQuestion, setCurrentQuestion] = useState(0);
  const [showScore, setShowScore] = useState(false);
  const [scoreGroupOne, setScoreGroupOne] = useState(0);
  const [scoreGroupTwo, setScoreGroupTwo] = useState(0);
  const [scoreGroupThree, setScoreGroupThree] = useState(0);
  const [scoreGroupFour, setScoreGroupFour] = useState(0);
  const [scoreGroupFive, setScoreGroupFive] = useState(0);

  const handleAnswerOptionClick = (value, group) => {
    console.log(group);
    console.log(value);
    console.log(scoreGroupOne);
    switch (group) {
      case 'Depression':
        setScoreGroupOne(scoreGroupOne + value);
        break;
      case 'Neurosis':
        setScoreGroupTwo(scoreGroupTwo + value);
        break;
      case 'Social anxiety':
        setScoreGroupThree(scoreGroupThree + value);
        break;
      case 'Asthenia':
        setScoreGroupFour(scoreGroupFour + value);
        break;
      case 'Insomnia':
        setScoreGroupFive(scoreGroupFive + value);
        break;
      default:
        break;
    }

    const nextQuestion = currentQuestion + 1;
    if (nextQuestion < questions.length) {
      setCurrentQuestion(nextQuestion);
    } else {
      setShowScore(true);
    }
  };
  return (
    <div className="quiz-container">
      <div className="quiz-info">
        <InfoOutlinedIcon fontSize="large" color="info" />
        <div className="quiz-info-text">
          <h2>EMOTIONAL STATE TEST</h2>
          <p>
            This test will help you to understand your emotional state. The test
            does not allow diagnosis, nor does it provide medical evaluations. A
            psychiatrist or clinical psychologist should be consulted to obtain
            an appropriate assessment.
          </p>
        </div>
      </div>
      <div className="question-container">
        {showScore ? (
          <div className="score-section">
            Results:
            <p>Depression: {scoreGroupOne}</p>
            <p>Neurosis: {scoreGroupTwo}</p>
            <p>Social anxiety: {scoreGroupThree}</p>
            <p>Asthenia: {scoreGroupFour}</p>
            <p>Insomnia: {scoreGroupFive}</p>
          </div>
        ) : (
          <>
            <div className="question-section">
              <div className="question-count">
                <span>Question {currentQuestion + 1}</span>/{questions.length}
              </div>
              <div className="question-text">
                {questions[currentQuestion].questionText}
              </div>
            </div>
            <div className="answer-section">
              {answerOptions.map((answerOption) => (
                <button
                  className="answer-button"
                  key={answerOption.answerText}
                  onClick={() =>
                    handleAnswerOptionClick(
                      answerOption.value,
                      questions[currentQuestion].questionGroup,
                    )
                  }>
                  {answerOption.answerText}
                </button>
              ))}
            </div>
          </>
        )}
      </div>
    </div>
  );
};
