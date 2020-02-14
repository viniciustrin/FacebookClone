import React from "react";
import { Grid, GridColumn, List } from "semantic-ui-react";
import { IAtividade } from "../../../models/atividade";
import AtividadeLista from "./AtividadeLista";
import AtividadeDetalhe from "../detalhes/AtividadeDetalhe";
import AtividadeForm from "../form/AtividadeForm";

interface IProps {
  atividades: IAtividade[];
  selecionarAtividade: (id: string) => void;
  atividadeSelecionada: IAtividade;
}

const AtividadeDashboard: React.FC<IProps> = ({
  atividades,
  selecionarAtividade,
  atividadeSelecionada
}) => {
  return (
    <Grid>
      <GridColumn width={10}>
        <AtividadeLista
          atividades={atividades}
          selecionarAtividade={selecionarAtividade}
        />
      </GridColumn>
      <GridColumn width={6}>
        {atividadeSelecionada && (
          <AtividadeDetalhe atividade={atividadeSelecionada} />
        )}
        <AtividadeForm />
      </GridColumn>
    </Grid>
  );
};

export default AtividadeDashboard;
