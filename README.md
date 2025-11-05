# 🔐 Mini Login

Um pequeno projeto em **C#** criado para praticar conceitos básicos de **entrada de dados**, **condicionais** e **loops**.  
O programa simula um mini sistema de login, pedindo ao usuário um nome de usuário e uma senha com pelo menos 8 caracteres.

---

## 🧠 Conceitos praticados

- Leitura de dados com `Console.ReadLine()`
- Estrutura de repetição `do...while`
- Estrutura condicional `if`
- Manipulação de strings e checagem de comprimento (`.Length`)
- Boas práticas com mensagens de feedback ao usuário

---

## 💻 Como funciona

1. O programa solicita que o usuário insira um **nome de usuário**.  
2. Em seguida, pede uma **senha**.  
3. Caso a senha tenha **menos de 8 caracteres**, o programa informa que é inválida e solicita novamente.  
4. Quando a senha atende o requisito, o programa exibe **“Login successful!”** 🎉  

---

## 🧩 Exemplo de execução
```
Enter an username:
aline

Enter a password (It must contain at least 8 digits):
12345
Invalid password

Enter a password (It must contain at least 8 digits):
12345678
Login successful!
```