import React, { useState, useEffect, Fragment } from "react";
import { Header, Icon, List, Container } from "semantic-ui-react";
import axios from "axios";
import { IAtividade } from "../../models/atividade";
import NavBar from "../../features/nav/NavBar";
import AtividadeDashboard from "../../features/atividades/dashboard/AtividadeDashboard";

const App = () => {
  const [atividades, setAtividades] = useState<IAtividade[]>([]);
  const [
    atividadeSelecionada,
    setAtividadeSelecionada
  ] = useState<IAtividade | null>(null);

  const handleAtividadeSelecionada = (id: string) => {
    setAtividadeSelecionada(atividades.filter(x => x.id === id)[0]);
  };

  useEffect(() => {
    axios
      .get<IAtividade[]>("http://localhost:5000/api/atividades")
      .then(response => {
        setAtividades(response.data);
      });
  }, []);

  return (
    <Fragment>
      <NavBar />
      <Container style={{ marginTop: "7em" }}>
        <AtividadeDashboard
          atividades={atividades}
          selecionarAtividade={handleAtividadeSelecionada}
          atividadeSelecionada={atividadeSelecionada!}
        />
      </Container>
    </Fragment>
  );
};

export default App;
