export default function Home() {
  return (
    <div style={styles.container}>
      <h1 style={styles.heading}>
        CONSUMO DA API C# COM FRONT EM NEXTJS
      </h1>

      <p style={styles.paragraph}>
        Clique em <strong style={styles.strong}>Usuários</strong> para ver os usuários cadastrados.
      </p>
    </div>
  );
}

const styles = {
  container: {
    textAlign: 'center',
    backgroundColor: '#f2f2f2',
    borderRadius: '8px',
    boxShadow: '0 0 10px rgba(0, 0, 0, 0.1)',
    margin: '50px auto',
    width: '80%',
    maxWidth: '600px',
  },
  heading: {
    fontSize: '24px',
    color: '#333',
    marginBottom: '20px',
  },
  paragraph: {
    fontSize: '16px',
    color: '#555',
  },
  strong: {
    fontWeight: 'bold',
    color: '#007bff',
  },
};


