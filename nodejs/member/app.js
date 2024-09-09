let express = require("express");
let app = express();
let bodyParser = require("body-parser");
let mysql = require("mysql");

//모듈 설치
//npm i express body-parser mysql

const port = process.env.PORT || 3030;

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));

//connect mysql database
let conn = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "1234",
  database: "mydb",
});

conn.connect();

app.get("/", (req, res) => {
  return res.json({
    error: false,
    message: "Welcome to RESTfull api with node js.",
  });
});

// 회원정보 리스트 요청
// URL : GET localhost:3030/members
app.get("/members", (req, res) => {
  conn.query("SELECT * FROM member", (error, results) => {
    if (error) throw error;

    let message = "";
    if (results === undefined || results.length == 0) {
      message = "Member is empty";
    } else {
      message = "Successfully retrived all Member";
    }

    return res.json({
      error: false,
      message: message,
      data: results,
    });
  });
});
// 회원정보 단건 요청
// URL: GET localhost:3030/members/2
app.get("/members/:id", (req, res) => {
  let id = req.params.id;
  let values = [id];

  conn.query(
    "SELECT * FROM member WHERE member_no=?",
    values,
    (error, results) => {
      if (error) throw error;

      let message = "";
      if (results === undefined || results.length == 0) {
        message = "Member is empty";
      } else {
        message = "Successfully retrived one Memberr";
      }

      return res.json({
        error: false,
        message: message,
        data: results,
      });
    }
  );
});

// 회원정보 추가하기
// URL: POST localhost:3030/members
app.post("/members", (req, res) => {
  let member_username = req.body.member_username;
  let member_password = req.body.member_password;
  let member_email = req.body.member_email;
  let member_joindate = null;

  //check validation
  if (!member_username || !member_password) {
    return res.status(400).send({
      error: true,
      message: "Please provide username and password",
    });
  } else {
    let values = [member_username, member_password, member_email];
    conn.query(
      "INSERT INTO member VALUES(0, ?, ?, ?, CURRENT_DATE)",
      values,
      (error, results, fields) => {
        if (error) throw error;
        return res.send({
          error: false,
          message: "Member successfully added",
          data: values,
        });
      }
    );
  }
});

// 회원정보 수정하기
// URL: PUT localhost:3030/members/2
app.put("/members/:id", (req, res) => {
  let id = req.params.id;
  let member_username = req.body.member_username;
  let member_password = req.body.member_password;
  let member_email = req.body.member_email;
  let member_joindate = req.body.member_joindate;

  //check validation
  if (!member_username || !member_password || !id) {
    return res.status(400).send({
      error: true,
      message: "Please provide id, member_username and member_password",
    });
  } else {
    let values = [
      member_username,
      member_password,
      member_email,
      member_joindate,
      id,
    ];
    conn.query(
      "UPDATE member SET member_username = ?, member_password = ?, member_email = ?, member_joindate = ? WHERE member_no = ?",
      values,
      (error, results, fields) => {
        if (error) throw error;

        let message = "";
        if (results.changedRows === 0) {
          message = "Member not found or data are same";
        } else {
          message = "Member successfully updated";
        }

        return res.send({
          error: false,
          message: message,
          data: [...values],
        });
      }
    );
  }
});

// 회원정보 삭제하기
// URL: DELETE localhost:3030/members/2
app.delete("/members/:id", (req, res) => {
  let id = req.params.id;

  //check validation
  if (!id) {
    return res.status(400).send({
      error: true,
      message: "Please provide member id",
    });
  } else {
    let values = [id];
    conn.query(
      "DELETE FROM member WHERE member_no = ?",
      values,
      (error, results, fields) => {
        if (error) throw error;

        let message = "";

        if (results.affectedRows === 0) {
          message = "Member not found";
        } else {
          message = "Member successfully deleted";
        }

        return res.send({
          error: false,
          message: message,
          data: [id],
        });
      }
    );
  }
});

app.listen(port, () => {
  console.log("Listening on port %d", port);
});

module.exports = app;
