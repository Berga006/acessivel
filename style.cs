/* styles.css */
body {
  font-family: Arial, sans-serif;
  margin: 0;
  padding: 0;
  line-height: 1.6;
}

header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  background: #111;
  color: #fff;
  padding: 1rem;
}

header .logo {
  max-height: 60px; /* deixei um pouco maior */
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
   BANNER
========================== */
.banner {
  text-align: center;
  padding: 2rem;
}

.banner img {
  max-width: 600px;   /* tamanho médio fixo */
  width: 100%;        /* responsivo */
  height: auto;
  margin-top: 1rem;
  border-radius: 8px;
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
  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
  gap: 1rem;
}

.galeria img {
  width: 100%;
  max-width: 350px;   /* limite para não ficarem gigantes */
  margin: auto;
  display: block;
  border-radius: 8px;
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
