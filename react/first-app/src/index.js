import React from "react";
import ReactDOM from "react-dom/client"; //React.js client Next.js/server
// import App from "./App";
// import Book from "./3-jsx/Book";
// import VM from "./3-jsx/VendingMachine";
import Clock from "./4-element/Clock";

const root = ReactDOM.createRoot(document.getElementById("root"));
//root.render(<App />);
//root.render(<Book name="리액트기초" price="1000" />);
//root.render(<VM price="1000" />);
root.render(<Clock />);
