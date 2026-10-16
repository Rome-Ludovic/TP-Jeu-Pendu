string[] mots = { 
    // === NATURE & ENVIRONNEMENT (50) ===
    "cascade", "volcan", "tornade", "falaise", "ruisseau", "crevasse", "archipel", "banquise", "tempete", "foudre",
	"foret", "desert", "savane", "toundra", "prairie", "glacier", "caverne", "colline", "horizon", "aurore",
	"chene", "bambou", "orchidee", "tournesol", "cactus", "baobab", "sapin", "nenuphar", "fougere", "mousse",
	"lion", "panthere", "dauphin", "aigle", "serpent", "girafe", "renard", "hibou", "papillon", "abeille",
	"requin", "baleine", "tortue", "saumon", "faucon", "guerison", "climat", "oxygene", "minerai", "cristal",

    // === TECHNOLOGIE & NUMÉRIQUE (50) ===
    "ordinateur", "logiciel", "clavier", "ecran", "processeur", "memoire", "reseau", "internet", "algorithme", "programme",
	"serveux", "donnees", "securite", "cryptage", "robotique", "capteur", "batterie", "faisceau", "frequence", "antenne",
	"application", "tablette", "smartphone", "domotique", "virtuel", "hologramme", "satellite", "fusa", "capsule", "drone",
	"interface", "connexion", "stockage", "affichage", "vibration", "numerique", "optique", "faisceau", "frequence", "signal",
	"finitude", "calcul", "focalisation", "automatisation", "filiation", "terminal", "filiere", "pixel", "firme", "pionnier",

    // === HISTOIRE, FANTASIE & MYTHOLOGIE (50) ===
    "chateau", "donjon", "rempart", "couronne", "sceptre", "armure", "bouclier", "epee", "lance", "catapulte",
	"dragon", "phenix", "licorne", "griffon", "centaure", "sylphe", "golem", "vampire", "sorcier", "alchimiste",
	"royaume", "empire", "dynastie", "alliance", "traite", "legende", "mythe", "epopee", "odyssee", "prophétie",
	"grimoire", "amulette", "talisman", "potion", "incantation", "rituel", "temple", "sanctuaire", "pyramide", "ruines",
	"chevalier", "paladin", "barbare", "nomade", "gladiateur", "corsaire", "pirate", "amiral", "empereur", "monarque",

    // === ALIMENTATION & GASTRONOMIE (50) ===
    "chocolat", "vanille", "cannelle", "caramel", "miel", "confiserie", "biscuit", "brioche", "croissant", "patisserie",
	"fromage", "baguette", "viande", "poisson", "legume", "fruit", "epice", "aromate", "vinaigre", "moutarde",
	"abricot", "framboise", "myrtille", "pamplemousse", "pastèque", "avocat", "artichaut", "asperge", "aubergine", "courgette",
	"restaurant", "brasserie", "cuisine", "recette", "marmite", "casserole", "fourneau", "moulin", "mixeur", "balance",
	"banquet", "buffet", "degustation", "saveur", "arome", "fraicheur", "gourmandise", "festin", "cocktail", "infusion",

    // === VOYAGE, TRANSPORT & GEOGRAPHIE (50) ===
    "vaisseau", "navire", "aeroplane", "locomotive", "bicyclette", "caravane", "sous-marin", "zeppelin", "tramway", "funiculaire",
	"boussole", "sextant", "maquette", "itineraire", "trajectoire", "bagage", "valise", "passeport", "frontiere", "douane",
	"metropole", "capitale", "continent", "peninsule", "isthme", "equateur", "tropique", "meridien", "altitude", "latitude",
	"voyageur", "explorateur", "pelerin", "passager", "equipage", "capitaine", "guide", "éclaireur", "pionnier", "aviateur",
	"aeroport", "gare", "port", "terminus", "viaduc", "tunnel", "autoroute", "sentier", "carrefour", "passerelle",

    // === ARTS, LITTÉRATURE & SPECTACLE (50) ===
    "peinture", "sculpture", "architecture", "mosaique", "fresque", "aquarelle", "gravure", "dessin", "esquisse", "palette",
	"symphonie", "orchestre", "concert", "opera", "melodie", "harmonie", "rythme", "partition", "instrument", "guitare",
	"theatre", "comedie", "tragedie", "drame", "scenario", "dialogue", "acteur", "metteur", "decor", "costume",
	"roman", "poesie", "ballade", "chronique", "biographie", "anthologie", "chapitre", "paragraphe", "metaphore", "allégorie",
	"cinema", "pellicule", "projecteur", "camera", "montage", "festival", "galerie", "musee", "exposition", "vernissage",

    // === MAISON, ARCHITECTURE & QUOTIDIEN (50) ===
    "fondation", "charpente", "façade", "toiture", "cheminee", "balcon", "terrasse", "veranda", "vestibule", "couloir",
	"salon", "cuisine", "chambre", "grenier", "cave", "atelier", "bibliotheque", "bureau", "penderie", "mobilier",
	"fauteuil", "canape", "armoire", "commode", "etagere", "horloge", "miroir", "lustre", "veilleuse", "cheminee",
	"fenetre", "persienne", "rideau", "coussin", "couverture", "tapis", "faience", "parquet", "mosaique", "boiserie",
	"clef", "serrure", "verrou", "poignée", "sonnette", "interrupteur", "ampoule", "radiateur", "ventilation", "climatisation",

    // === SCIENCES, MATHS & ESPACE (50) ===
    "atome", "molecule", "electron", "neutron", "proton", "quarks", "gravite", "orbite", "galaxie", "nebuleuse",
	"equation", "theoreme", "geometrie", "algebre", "calcul", "statistique", "matrice", "vecteur", "fractale", "infini",
	"telescope", "microscope", "laboratoire", "eprouvette", "pipette", "fiole", "lentille", "prisme", "laser", "faisceau",
	"evolution", "genetique", "chromosome", "mutation", "organisme", "ecosysteme", "biodiversite", "taxonomie", "fossile", "sediment",
	"astronomie", "astrophysique", "cosmologie", "geologie", "paleontologie", "archeologie", "anthropologie", "sociologie", "psychologie", "philosophie",

    // === SPORTS, JEUX & LOISIRS (50) ===
    "athletisme", "gymnastique", "natation", "aviron", "escrime", "cyclisme", "marathon", "decatlon", "biathlon", "triathlon",
	"football", "basketball", "volleyball", "handball", "rugby", "tennis", "badminton", "pingpong", "golf", "billard",
	"echiquier", "damier", "domino", "puzzle", "mots-croises", "sudoku", "solitaire", "labyrinthe", "enigme", "charade",
	"competition", "tournoi", "championnat", "olympiade", "medaille", "trophee", "podium", "arbitre", "entraineur", "capitaine",
	"randonnee", "escalade", "alpinisme", "camping", "caravane", "plongee", "surf", "ski", "snowboard", "patinage",

    // === MOTS ABSTRAITS, QUALITÉS & CONCEPTS (50) ===
    "liberte", "justice", "egalite", "fraternite", "harmonie", "sagesse", "courage", "audace", "patience", "tolerance",
	"curiosite", "creativite", "imagination", "intuition", "reflexion", "logique", "memoire", "intelligence", "perspicacite", "lucidite",
	"sympathie", "empathie", "bienveillance", "altruisme", "generosite", "gratitude", "sincerite", "loyaute", "fidelite", "serenite",
	"ambition", "determination", "perseverance", "volonte", "energie", "dynamisme", "enthousiasme", "passion", "vocation", "destinee",
	"mystere", "secret", "illusion", "paradoxe", "enigme", "destin", "hasard", "coincidence", "chance", "victoire",
};


int tentativesRestantes = 6;
bool jeuTermine = false;
char lettreDevinee;
bool estUneLettre;
Random random = new Random();
string motADeviner = mots[random.Next(mots.Length)].ToUpper();


// Uncomment this to show the word :)
Console.WriteLine($"le mot a deviner est: {motADeviner}");
int nbLettre = motADeviner.Length;
char[] lettresCachees = new char[nbLettre];
affLettresCache();
while (!jeuTermine)
{
	affLettres();
	if (tentativesRestantes <= 0)
	{
		Console.WriteLine("\r\nYou lose (¬_¬)");
		Console.WriteLine($"\r\nLe mot etait :{motADeviner}");
		jeuTermine = true;
	}
	if (motADeviner == new string(lettresCachees))
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("\r\nYou win :D");
		jeuTermine = true;
		youWin();
	}
}

void affLettres()
{
	Console.WriteLine("\r\nDevinez une lettre : ");
	lettreDevinee = Console.ReadLine().ToUpper()[0];

	estUneLettre = motADeviner.Contains(lettreDevinee);

	for (int i = 0; i < nbLettre; i++)
	{
		if (estUneLettre && lettreDevinee == motADeviner[i])
		{
			lettresCachees[i] = lettreDevinee;
		}
		else if (!estUneLettre && lettreDevinee != motADeviner[i] && i == nbLettre - 1)
		{
			tentativesRestantes--;
		}
		Console.Write(lettresCachees[i]);
	}
	Console.WriteLine($"\r\nTentatives restantes: {tentativesRestantes}");
	if (tentativesRestantes == 6)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n=========\r\n");
	}
	if (tentativesRestantes == 5)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========\r\n");
	}
	if (tentativesRestantes == 4)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========\r\n");
	}
	if (tentativesRestantes == 3)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n  O   |\r\n /|   |\r\n      |\r\n      |\r\n=========\r\n");
	}
	if (tentativesRestantes == 2)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |\r\n=========\r\n");
	}
	if (tentativesRestantes == 1)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n /    |\r\n      |\r\n=========\r\n");
	}
	if (tentativesRestantes == 0)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========\r\n");
	}
}

void affLettresCache()
{
	for (int i = 0; i < nbLettre; i++)
	{
		lettresCachees[i] = '_';
		Console.Write(lettresCachees[i]);
	}
}

void youWin()
{
	while (true)
	{
		Console.Clear();
		Console.WriteLine("  \\o/ \n   |  \n  / \\ \n");
		Console.WriteLine("  \\o/ \n   |  \n  / \\ \n");
		Console.WriteLine("  \\o/ \n   |  \n  / \\ \n");
		Console.WriteLine("  \\o/ \n   |  \n  / \\ \n");
		Console.WriteLine("  \\o/ \n   |  \n  / \\ \n");
		Console.WriteLine("  \\o/ \n   |  \n  / \\ \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine("   o/ \n  /|  \n  / \\ \n");
		Console.WriteLine("   o/ \n  /|  \n  / \\ \n");
		Console.WriteLine("   o/ \n  /|  \n  / \\ \n");
		Console.WriteLine("   o/ \n  /|  \n  / \\ \n");
		Console.WriteLine("   o/ \n  /|  \n  / \\ \n");
		Console.WriteLine("   o/ \n  /|  \n  / \\ \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine("  _o/ \n   |  \n  / > \n");
		Console.WriteLine("  _o/ \n   |  \n  / > \n");
		Console.WriteLine("  _o/ \n   |  \n  / > \n");
		Console.WriteLine("  _o/ \n   |  \n  / > \n");
		Console.WriteLine("  _o/ \n   |  \n  / > \n");
		Console.WriteLine("  _o/ \n   |  \n  / > \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine("    o_ \n   /|  \n   / \\ \n");
		Console.WriteLine("    o_ \n   /|  \n   / \\ \n");
		Console.WriteLine("    o_ \n   /|  \n   / \\ \n");
		Console.WriteLine("    o_ \n   /|  \n   / \\ \n");
		Console.WriteLine("    o_ \n   /|  \n   / \\ \n");
		Console.WriteLine("    o_ \n   /|  \n   / \\ \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine(" \\o   \n  |\\  \n / \\  \n");
		Console.WriteLine(" \\o   \n  |\\  \n / \\  \n");
		Console.WriteLine(" \\o   \n  |\\  \n / \\  \n");
		Console.WriteLine(" \\o   \n  |\\  \n / \\  \n");
		Console.WriteLine(" \\o   \n  |\\  \n / \\  \n");
		Console.WriteLine(" \\o   \n  |\\  \n / \\  \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine(" \\o_  \n  |   \n < \\  \n");
		Console.WriteLine(" \\o_  \n  |   \n < \\  \n");
		Console.WriteLine(" \\o_  \n  |   \n < \\  \n");
		Console.WriteLine(" \\o_  \n  |   \n < \\  \n");
		Console.WriteLine(" \\o_  \n  |   \n < \\  \n");
		Console.WriteLine(" \\o_  \n  |   \n < \\  \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine(" _o    \n  |\\   \n / \\   \n");
		Console.WriteLine(" _o    \n  |\\   \n / \\   \n");
		Console.WriteLine(" _o    \n  |\\   \n / \\   \n");
		Console.WriteLine(" _o    \n  |\\   \n / \\   \n");
		Console.WriteLine(" _o    \n  |\\   \n / \\   \n");
		Console.WriteLine(" _o    \n  |\\   \n / \\   \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine("  \\o/ \n   |  \n  ~ ~ \n");
		Console.WriteLine("  \\o/ \n   |  \n  ~ ~ \n");
		Console.WriteLine("  \\o/ \n   |  \n  ~ ~ \n");
		Console.WriteLine("  \\o/ \n   |  \n  ~ ~ \n");
		Console.WriteLine("  \\o/ \n   |  \n  ~ ~ \n");
		Console.WriteLine("  \\o/ \n   |  \n  ~ ~ \n");
		Thread.Sleep(300);
	}
}
