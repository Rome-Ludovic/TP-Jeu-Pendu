string[] mots = { 
    "diagnostic", "traitement", "patient", "symptômes", "médecin",
	"ambulance", "clinique", "chirurgie", "ordonnance", "thermomètre",
	"stéthoscope", "vaccination", "infirmier", "pharmacie", "allergie",
	"fracture", "guérison", "analyse", "scanner", "thérapie",
	"blessure", "tension", "pouls", "urgence", "vitamine",
    "artère", "cellule", "embryon", "globule", "hormone",
	"muscle", "neurone", "plasma", "poumon", "cerveau",
	"estomac", "foie", "intestin", "squelette", "tendon",
	"veine", "viscère", "cartilage", "moelle", "tissu",
	"abdomen", "amygdale", "appendice", "bronche", "clavicule",
	"cortex", "crâne", "fémur", "ganglion", "glande",
	"larynx", "ligament", "muqueuse", "pharynx", "rate",
	"rein", "rétine", "sinus", "vertèbre", "vessie",
    "dermatologue", "pédiatre", "radiographie", "réanimation", "cardiologue",
	"chirurgien", "dentiste", "gériatre", "neurologue", "opticien",
	"orthopédiste", "psychologue", "radiologue", "thérapeute", "virologue",
	"allergologue", "ambulancier", "biologiste", "brancardier", "gynécologue",
	"kinésithérapeute", "nutritionniste", "obstétricien", "oncologue", "ophtalmologue",
	"oto-rhino-laryngologiste", "pharmacien", "psychiatre", "rhumatologue", "urologue",
    "bactérie", "contamination", "diabète", "douleur", "épidémie",
	"infection", "maladie", "microbe", "pathologie", "traumatisme",
	"tumeur", "ulcère", "virus", "asthme", "bronchite",
	"entorse", "migraine", "paralysie", "pneumonie", "sclérose",
	"accident", "anémie", "anévrisme", "arthrose", "carence",
	"choléra", "commotion", "dépression", "dermatose", "dyslexie",
	"embolie", "épilepsie", "glaucome", "hépatite", "hypertension",
	"insomnie", "leucémie", "mycose", "otite", "pandémie",
    "anesthésie", "antibiotique", "brancard", "cicatrice", "dosimétrie",
	"endoscopie", "examen", "fièvre", "génétique", "immunité",
	"injection", "laboratoire", "médicament", "oxymètre", "pansement",
	"perfusion", "piqûre", "sédation", "sérum", "suture",
	"brûlure", "capsule", "comprimé", "sirop", "visite",
	"analgésique", "antidépresseur", "antiseptique", "aspirine", "collyre",
	"cortisone", "crème", "gélule", "ibuprofène", "insuline",
	"onguent", "paracétamol", "pommade", "sirop", "pastille",
    "audiogramme", "autopsie", "bistouri", "brise-jet", "canule",
	"cathéter", "civière", "compresse", "défibrillateur", "dentifrice",
	"échographie", "électrocardiogramme", "endoscope", "gant", "incubateur",
	"laser", "loupe", "masque", "microscope", "otoscope",
	"pèse-personne", "pince", "pipette", "prothèse", "radioscope",
	"scalpel", "seringue", "spatule", "tensiomètre", "fauteuil"
};

int tentativesRestantes = 6;
bool jeuTermine = false;
char lettreDevinee;
bool estUneLettre;
Random random = new Random();
string motADeviner = mots[random.Next(mots.Length)].ToUpper();


// Uncomment this to show the word :)
//Console.WriteLine($"le mot a deviner est: {motADeviner}");
int nbLettre = motADeviner.Length;
char[] lettresCachees = new char[nbLettre];

affLettresCache();
while (!jeuTermine)
{
	affLettres();
	if (tentativesRestantes <= 0)
	{
		Console.WriteLine("\r\nYou lose (¬_¬)");
		jeuTermine = true;
	}
	if (motADeviner == new string(lettresCachees))
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("\r\nYou win :D");
		jeuTermine = true;
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
			Console.WriteLine($"\r\nTentatives restantes: {tentativesRestantes}");
		}
		Console.Write(lettresCachees[i]);
	}
	if (tentativesRestantes == 6)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n=========\r\n");
	}
	// 5 tentatives restantes : La tête
	if (tentativesRestantes == 5)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========\r\n");
	}
	// 4 tentatives restantes : Le corps
	if (tentativesRestantes == 4)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========\r\n");
	}
	// 3 tentatives restantes : Premier bras
	if (tentativesRestantes == 3)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n  O   |\r\n /|   |\r\n      |\r\n      |\r\n=========\r\n");
	}
	// 2 tentatives restantes : Deuxième bras
	if (tentativesRestantes == 2)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |\r\n=========\r\n");
	}
	// 1 tentative restante : Première jambe
	if (tentativesRestantes == 1)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n /    |\r\n      |\r\n=========\r\n");
	}
	// 0 tentative restante : Pendu complet (Perdu)
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
