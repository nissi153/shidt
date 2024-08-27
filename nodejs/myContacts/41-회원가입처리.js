const express = require("express");
const app = express();

const port = 3030; //리액트 3000, 노드서버 3030

app.use(express.json()); // For JSON payloads
app.use(express.urlencoded({ extended: true })); // For URL-encoded payloads

app.post("/signup", (req, res) => {
  const { username, password, gender } = req.body;

  res.status(201).json({ username, password, gender });
});

app.listen(port, () => {
  console.log(`${port}번 포트에서 서버 실행 중`);
});
