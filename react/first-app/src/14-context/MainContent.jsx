import { useContext, useState } from "react";
import ThemeContext from "./ThemeContext";

//테마변경 : Dark, Light 테마 중 하나
//상태변수 공유는 단방향으로만 가능하다.
//APP 안에서 많은 컴퍼넌트들이 공유해야 되는 상태변수(로그인여부,테마)는 전역형태가 필요하다.
//어떤 컴퍼넌트에서도 바로 접근할 수 있게 해주는 것 : useContext 훅이다.
function MainContent(props) {
  const [theme, setTheme] = useContext(ThemeContext);

  const styles = {};
  return <div style={styles}></div>;
}

export default MainContent;
