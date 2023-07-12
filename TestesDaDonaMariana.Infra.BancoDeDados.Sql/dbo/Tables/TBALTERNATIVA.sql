CREATE TABLE [dbo].[TBALTERNATIVA] (
    [id]                 INT          IDENTITY (1, 1) NOT NULL,
    [idLetra]            VARCHAR (10) NOT NULL,
    [texto]              VARCHAR (50) NOT NULL,
    [alternativaCorreta] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_TBAlternativa] PRIMARY KEY CLUSTERED ([texto] ASC),
    CONSTRAINT [FK_TBAlternativa_Questao] FOREIGN KEY ([questao_id]) REFERENCES [dbo].[TBQuestao] ([id])
);



