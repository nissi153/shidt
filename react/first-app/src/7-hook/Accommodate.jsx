import React, { useState, useEffect } from "react";
import useCounter from "./useCounter";

const MAX_CAPACITY = 10; //최대값 10 최소값 0

function Accommodate(props) {
  const [isFull, setIsFull] = useState(false);
  const [count, addCount, subCount] = useCounter(0);

  useEffect(() => {
    console.log("useEffect() called!");
    console.log(`isFull:${isFull}`);
  });
}

export default Accommodate;
