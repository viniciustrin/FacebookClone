import React from "react";
import { Item, Image, Button, Segment, Label } from "semantic-ui-react";
import { IAtividade } from "../../../models/atividade";

interface IProps {
  atividades: IAtividade[];
  selecionarAtividade: (id: string) => void;
}

const AtividadeLista: React.FC<IProps> = ({
  atividades,
  selecionarAtividade
}) => {
  return (
    <Segment clearing>
      <Item.Group divided>
        {atividades.map(atividade => (
          <Item key={atividade.id}>
            <Item.Content>
              <Item.Header as="a">{atividade.titulo}</Item.Header>
              <Item.Meta>{atividade.data}</Item.Meta>
              <Item.Description>
                <div>{atividade.descricao}</div>
                <div>
                  {atividade.cidade}, {atividade.local}
                </div>
              </Item.Description>
              <Item.Extra>
                <Button
                  onClick={() => selecionarAtividade(atividade.id)}
                  floated="right"
                  content="View"
                  color="blue"
                />
                <Label basic content={atividade.categoria} />
              </Item.Extra>
            </Item.Content>
          </Item>
        ))}
      </Item.Group>
    </Segment>
  );
};

export default AtividadeLista;
