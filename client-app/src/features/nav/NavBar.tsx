import React from "react";
import { Menu, Container, Button } from "semantic-ui-react";

const NavBar = () => {
  return (
    <Menu fixed="top" inverted>
      <Container>
        <Menu.Item header>
          <img src="/assets/logo.png" alt="Logo" style={{ marginRight: 10 }} />
          FaceClone
        </Menu.Item>
        <Menu.Item name="Atividades" />
        <Menu.Item>
          <Button positive content="Inserir Atividade" />
        </Menu.Item>
      </Container>
    </Menu>
  );
};

export default NavBar;
