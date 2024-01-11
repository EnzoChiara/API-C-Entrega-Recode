import styles from './card.module.css';

export default async function Card() {
  try {
    const response = await fetch('http://localhost:5121/api/Usuario');
    const cards = await response.json();

    console.log(cards);

    return (
      <div className={styles.container}>
        {cards?.map((card) => (
          <div key={card.idUsuario} className={styles.card}>
            <img src={card.fotoPerfil} className={styles.profileImage} />

            <div className={styles.cardContent}>
              <div className={styles.cardTitle}>
                <p className={styles.name}>{card.nome} {card.sobrenome}</p>
              </div>
              <div className={styles.userInfo}>
                <p className={styles.infoItem}>Email: {card.email}</p>
                <p className={styles.infoItem}>Senha: {card.senha}</p>
                <p className={styles.infoItem}>Contato: {card.contato}</p>
              </div>
            </div>
          </div>
        ))}
      </div>
    );
  } catch (error) {
    console.error('Erro ao obter dados da API:', error);
    return <p>Erro ao carregar dados da API.</p>;
  }
}

