
import React from 'react';
import './Logo.scss';
import { SVG_LOGO_FULL, SVG_LOGO_SMALL } from 'enums';

export const Logo: React.FC = () => {
  return (
    <div className="logo">
      <a href="/">
        {SVG_LOGO_FULL}
        {SVG_LOGO_SMALL}
      </a>
    </div>
  );
};
