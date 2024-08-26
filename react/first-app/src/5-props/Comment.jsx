import React from "react";

const style = {
  wrapper: {
    margin: 8,
    padding: 8,
    border: "1px solid grey",
    height: 100,
    width: 100,
    backgroundColor: "green",
  },
};

function Comment(props) {
  return <div style={style.wrapper}></div>;
}

export default Comment;
