import React, { useState } from "react";
import "./App.css";

const LoginView = ({ onLogin }) => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");

  const handleLogin = async () => {
    try {
      const response = await fetch("sua-url-api/login", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ username, password }),
      });

      if (response.ok) {
        const data = await response.json();
        onLogin(data); // Chama a função passada por prop para lidar com o login bem-sucedido
      } else {
        console.error("Erro ao fazer login");
      }
    } catch (error) {
      console.error("Erro:", error);
    }
  };

  return (
    <div class="container-pai">
      <div className="login-container">
        <h1>Login</h1>
        <label className="label-login">Usuário ou email</label>
        <input
          className="input-login"
          type="text"
          value={username}
          onChange={(e) => setUsername(e.target.value)}
        />
        <br />
        <label className="label-login">Senha</label>
        <input
          className="input-login"
          type="password"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
        />
        <br />
        <button className="botao-login" onClick={handleLogin}>
          Login
        </button>
      </div>
    </div>
  );
};

export default LoginView;
