import Link from 'next/link'

export default function Header() {
	return (
		<header className="header">
			<img src="/recodeLogo.png" alt="logo" />
			<ul>
				<li>
					<Link href="/RotaUm">Usuarios</Link>
				</li>
				
			</ul>
		</header>
	)
}