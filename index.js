// src/fileReader/index.js
import { useState } from 'react';

export const useFileReader = () => {
  const [content, setContent] = useState(null);
  const [error, setError] = useState(null);

  const readFile = (file) => {
    const reader = new FileReader();
    reader.onload = (e) => setContent(e.target.result);
    reader.onerror = (e) => setError(e.target.error);
    reader.readAsText(file);
  };

  return { content, error, readFile };
};

export const readFileAsText = (file) => {
  return new Promise((resolve, reject) => {
    const reader = new FileReader();
    reader.onload = (e) => resolve(e.target.result);
    reader.onerror = (e) => reject(e.target.error);
    reader.readAsText(file);
  });
};
