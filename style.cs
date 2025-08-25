/* ==========================
   ESTILO GLOBAL
========================== */
body {
  font-family: Arial, sans-serif;
  margin: 0;
  padding: 0;
  line-height: 1.6;
}

/* ==========================
   HEADER
========================== */
header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  background: #111;
  color: #fff;
  padding: 1rem;
}

header .logo {
  max-height: 60px;
}

nav ul {
  list-style: none;
  display: flex;
  gap: 1rem;
  margin: 0;
  padding: 0;
}

nav a {
  color: #fff;
  text-decoration: none;
}

/* ==========================
   ESTILO UNIFICADO PARA IMAGENS
========================== */
img {
  max-width: 400px;    /* Limite geral de largura */
  width: 100%;         /* Ajusta ao container */
  height: auto;        /* Mantém proporção */
  display: block;
  margin: 20px auto;   /* Centraliza e dá espaçamento vertical */
  border-radius: 8px;  /* Borda suave */
}

.banner img {
  max-width: 600px;    /* Banner maior para destaque */
}

.galeria img {
  max-width: 300px;    /* Galeria compacta */
  transition: transform 0.3s; /* Efeito leve ao passar o mouse */
}

.galeria img:hover {
  transform: scale(1.05);
}

/* ==========================
   BANNER
========================== */
.banner {
  text-align: center;
  padding: 2rem;
}

/* ==========================
   GALERIA
========================== */
.galeria {
  padding: 2rem;
  background: #f4f4f4;
}

.galeria .grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
  gap: 1.5rem;
  justify-items: center; /* Centraliza imagens pequenas */
}

/* ==========================
   CONTATO
========================== */
.contato {
  padding: 2rem;
}

form {
  display: flex;
  flex-direction: column;
  gap: 0.5rem;
}

form input, form textarea {
  width: 100%;
  box-sizing: border-box;
  padding: 0.5rem;
  border: 1px solid #ccc;
  border-radius: 4px;
}

button {
  padding: 0.7rem;
  background: #e63946;
  color: #fff;
  border: none;
  border-radius: 4px;
  cursor: pointer;
}

button:hover {
  background: #d62828;
}

/* ==========================
   FOOTER
========================== */
footer {
  background: #111;
  color: #fff;
  text-align: center;
  padding: 1rem;
}

/* ==========================
   ACESSIBILIDADE
========================== */
.acessibilidade {
  position: fixed;
  top: 10px;
  right: 10px;
  display: flex;
  flex-direction: column;
  gap: 0.5rem;
}

.acessibilidade button {
  padding: 0.5rem;
  font-size: 1rem;
}

/* ==========================
   ALTO CONTRASTE
========================== */
.alto-contraste {
  background: #000 !important;
  color: #fff !important;
}

.alto-contraste a {
  color: yellow !important;
}

/* ==========================
   RESPONSIVIDADE
========================== */
@media (max-width: 600px) {
  header {
    flex-direction: column;
    align-items: flex-start;
    gap: 1rem;
  }

  .banner img {
    max-width: 100%;
  }

  .galeria .grid {
    grid-template-columns: repeat(auto-fit, minmax(150px, 1fr));
    gap: 1rem;
  }

  .acessibilidade button {
    font-size: 1.2rem;
    padding: 0.6rem;
  }
}
