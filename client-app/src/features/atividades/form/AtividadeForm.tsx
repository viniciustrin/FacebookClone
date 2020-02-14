import React from "react";
import { Segment, Form, FormInput, FormTextArea } from "semantic-ui-react";

const AtividadeForm = () => {
  return (
    <Segment>
      <Form>
        <FormInput placeholder="Título" />
        <FormTextArea rows={2} placeholder="Descrição" />
        <FormInput placeholder="Categoria" />
        <FormInput type="date" placeholder="Data" />
        <FormInput placeholder="Cidade" />
        <FormInput placeholder="Local" />
      </Form>
    </Segment>
  );
};

export default AtividadeForm;
