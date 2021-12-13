import React from 'react';
import './Copyright.scss';

export const Copyright: React.FC = () => {
  const copyright = 'Psychological Help Inc. (c) 2021, All rights reserved.';
  return (
    <div className="copyright">
      Developed by
      <span className="team-name"> Yellow Team</span> | {copyright}
    </div>
  );
};
