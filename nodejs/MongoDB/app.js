const express = require("express");
const app = express();

const port = 3030;

app.get("/", (req, res) => {
  res.status(200); //상태코드를 200으로 설정
  res.send("Hello Express~");
});

app.listen(port, () => {
  console.log(`${port}번 포트에서 서버 실행 중...`);
});
