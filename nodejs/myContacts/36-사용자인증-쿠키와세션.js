//웹 애플리케이션에서 사용자 인증하기

//1.쿠키 - 클라이언트(PC,Mobile)에 저장되는 임시데이터
//2.세션 - 서버에 저장되는 데이터(DB, 메모리)
//3.토큰 - 클라이언트와 서버에 저장되는 암호된 데이터

//쿠키파서, JWT(Json Web Token) 미들웨어 설치
//npm i cookie-parser jsonwebtoken

//쿠키 데이터 다루기
const express = require("express");
const cookieParser = require("cookie-parser");

const app = express();
app.use(cookieParser());

app.get("/", (req, res) => {
    // HTTP 응답 헤더 : setCookie: 값을 넣어서 응답하면, 클라가 쿠키를 저장한다.
    // httpOnly : HTTP통신을 통해서만 쿠키를 생성하도록 설정. JS통해서 쿠키생성을 막음.
    res.cookie("Kim", "1234", {httpOnly:true});
    res.send("쿠키 생성");
});

//MySQL 
//SQL언어 지원  = select,insert,update,delete
//MongoDB
//No-SQL = create,save,delete,update, 검색,정렬,갯수제한

//카페 - 공정현황 5개 엑셀파일 