import React from "react";
import ReactDOM from "react-dom/client"; //React.js client Next.js/server
import App from "./App";
import Book from "./3-jsx/Book";

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(<Book name="리액트 초급" price="1000" />);
