import React from "react";
import { Image, Card, Icon, Button, ButtonGroup } from "semantic-ui-react";
import { IAtividade } from "../../../models/atividade";

interface IProps {
  atividade: IAtividade;
}

const AtividadeDetalhe: React.FC<IProps> = ({ atividade }) => {
  return (
    <Card fluid>
      <Image
        src={`assets/categoria/${atividade.categoria}.jpg`}
        wrapped
        ui={false}
      />
      <Card.Content>
        <Card.Header>{atividade.titulo}</Card.Header>
        <Card.Meta>
          <span className="date">{atividade.data}</span>
        </Card.Meta>
        <Card.Description>{atividade.descricao}</Card.Description>
      </Card.Content>
      <Card.Content extra>
        <ButtonGroup widths={2}>
          <Button basic color="blue" content="Edit" />
          <Button basic color="grey" content="Cancel" />
        </ButtonGroup>
      </Card.Content>
    </Card>
  );
};

export default AtividadeDetalhe;
