import React from "react";
import ReactDOM from "react-dom/client"; //React.js client Next.js/server
import App from "./App";
import Book from "./3-jsx/Book";
import VM from "./3-jsx/VendingMachine";

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(<VM price="1000" />);
