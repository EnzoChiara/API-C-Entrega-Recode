import styles from '../Card/card.module.css';

export default async function Card2() {
     const cards = await fetch('http://localhost:5120/api/Usuario').then(res => res.json());
     console.log(cards);


    return (
        <div className={styles.container}>
            {cards?.map((card => (
                <div key={card.id} className={styles.card}>
                    <img src={card.url} alt={card.title} />
                    <div className={styles.card_title}>
                        <p>{card.name}</p>
                    </div>
                </div>

            )))}
        </div>
    )
}