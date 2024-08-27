import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom"; //하이퍼링크-바로가기
import styled from "styled-components";
import Button from "../ui/Button";
import PostList from "../list/PostList";

//모든 콘텐츠를 감싸는 최상위 DIV
const Wrapper = styled.div`
  padding: 16px;
  width: calc(100% - 32px);
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
`;
const Container = styled.div`
  width: 100%;
  max-width: 720px;
  display: flex;
  flex-direction: column;
`;

function MainPage() {
  const [posts, setPosts] = useState([]);
  const navigate = useNavigate();

  return (
    <Wrapper>
      <Container>
        <Button></Button>
        <PostList></PostList>
      </Container>
    </Wrapper>
  );
}

export default MainPage;
