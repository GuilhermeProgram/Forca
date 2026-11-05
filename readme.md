# Forca

Jogo da forca de console em C#. O programa escolhe uma palavra e o jogador tenta descobrir letra por letra, com no máximo 6 erros.

## Como jogar

1. O jogo mostra um traço para cada letra da palavra.
2. Digite uma letra e aperte Enter.
3. Se a letra existe, ela aparece nas posições certas. Se não existe, conta um erro.
4. Você ganha ao revelar a palavra inteira e perde ao chegar a 6 erros.

Regras do jogo:
- Só vale uma letra por vez.
- Maiúsculas e minúsculas são tratadas igual.
- Letras repetidas são recusadas e não contam como erro.

## Como rodar

Pré-requisito: [.NET SDK](https://dotnet.microsoft.com/download) instalado.

```bash
git clone https://github.com/GuilhermeProgram/Forca.git
cd Forca
dotnet run
```

## O que eu pratiquei

- Variáveis e laços (`while`) com condições combinadas (`&&`, `!`)
- Decisões com `if / else if / else`
- Texto: `Length`, `Contains`, `ToLower`, acesso por posição (`palavra[i]`)
- Estado do jogo (letras acertadas, letras tentadas, erros, vitória com `bool`)
- Validação de entrada do jogador

## Próximos passos

- [ ] Sortear a palavra de uma lista (array) em vez de usar uma fixa
- [ ] Desenhar o boneco da forca a cada erro
- [ ] Perguntar se o jogador quer jogar de novo
