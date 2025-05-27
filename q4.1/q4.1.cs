using System;
using System.Collections.Generic;

/**
    Faça a abstração que será usada para o gerênciamento
    de uma universidade. Para isso você terá alunos com
    nome e Registro Universitário (RA). Além disso, você
    terá que possuir turma com nome do professor, uma
    disciplina, uma lista de alunos e o horário é denotada 
    por um Enum com todas as possiblidades. Você terá
    facilidade se o aluno tiver uma lista de turmas.

    A classe Universidade tem uma lista de todos os alunos
    e turmas. Além de uma função de matricular que pega
    um aluno e turma conhecida coloca o aluno na turma,
    porém, ele válida duas coisas:

    - Se o aluno não está fazendo outra turma no mesmo
    horário.
    - Se a turma já não possui esse aluno ou está cheia
    com o total de 40 alunos.
 **/