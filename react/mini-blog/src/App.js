import { BrowserRouter, Routes, Route } from "react-router-dom";
import styled from "styled-components";

//Pages
// MainPage
// PostWritePage
// PostViewPage

const MainTitleText = styled.p`
  font-size: 24px;
  font-weight: bold;
  text-align: center;
`;

function App() {
  return <MainTitleText>홍길동의 미니블로그</MainTitleText>;
}

export default App;
