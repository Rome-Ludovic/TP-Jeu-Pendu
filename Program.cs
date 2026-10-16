string[] mots = { 
    "diagnostic", "traitement", "patient", "symptomes", "medecin",
	"ambulance", "clinique", "chirurgie", "ordonnance", "thermometre",
	"stethoscope", "vaccination", "infirmier", "pharmacie", "allergie",
	"fracture", "guerison", "analyse", "scanner", "therapie",
	"blessure", "tension", "pouls", "urgence", "vitamine",
    "artere", "cellule", "embryon", "globule", "hormone",
	"muscle", "neurone", "plasma", "poumon", "cerveau",
	"estomac", "foie", "intestin", "squelette", "tendon",
	"veine", "viscere", "cartilage", "moelle", "tissu",
	"abdomen", "amygdale", "appendice", "bronche", "clavicule",
	"cortex", "crâne", "femur", "ganglion", "glande",
	"larynx", "ligament", "muqueuse", "pharynx", "rate",
	"rein", "retine", "sinus", "vertebre", "vessie",
    "dermatologue", "pediatre", "radiographie", "reanimation", "cardiologue",
	"chirurgien", "dentiste", "geriatre", "neurologue", "opticien",
	"orthopediste", "psychologue", "radiologue", "therapeute", "virologue",
	"allergologue", "ambulancier", "biologiste", "brancardier", "gynecologue",
	"kinesitherapeute", "nutritionniste", "obstetricien", "oncologue", "ophtalmologue",
	"pharmacien", "psychiatre", "rhumatologue", "urologue",
    "bacterie", "contamination", "diabete", "douleur", "epidemie",
	"infection", "maladie", "microbe", "pathologie", "traumatisme",
	"tumeur", "ulcere", "virus", "asthme", "bronchite",
	"entorse", "migraine", "paralysie", "pneumonie", "sclerose",
	"accident", "anemie", "anevrisme", "arthrose", "carence",
	"cholera", "commotion", "depression", "dermatose", "dyslexie",
	"embolie", "epilepsie", "glaucome", "hepatite", "hypertension",
	"insomnie", "leucemie", "mycose", "otite", "pandemie",
    "anesthesie", "antibiotique", "brancard", "cicatrice", "dosimetrie",
	"endoscopie", "examen", "fievre", "genetique", "immunite",
	"injection", "laboratoire", "medicament", "oxymetre", "pansement",
	"perfusion", "piqûre", "sedation", "serum", "suture",
	"brûlure", "capsule", "comprime", "sirop", "visite",
	"analgesique", "antidepresseur", "antiseptique", "aspirine", "collyre",
	"cortisone", "creme", "gelule", "ibuprofene", "insuline",
	"onguent", "paracetamol", "pommade", "sirop", "pastille",
    "audiogramme", "autopsie", "bistouri", "canule",
	"catheter", "civiere", "compresse", "defibrillateur", "dentifrice",
	"echographie", "electrocardiogramme", "endoscope", "gant", "incubateur",
	"laser", "loupe", "masque", "microscope", "otoscope",
	"pince", "pipette", "prothese", "radioscope",
	"scalpel", "seringue", "spatule", "tensiometre", "fauteuil"
};

int tentativesRestantes = 6;
bool jeuTermine = false;
char lettreDevinee;
bool estUneLettre;
Random random = new Random();
string motADeviner = mots[random.Next(mots.Length)].ToUpper();


// Uncomment this to show the word :)
// Console.WriteLine($"le mot a deviner est: {motADeviner}");
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
	// 2 tentatives restantes : Deuxieme bras
	if (tentativesRestantes == 2)
	{
		Console.WriteLine("\r\n  +---+\r\n\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |\r\n=========\r\n");
	}
	// 1 tentative restante : Premiere jambe
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

void youWin()
{
	while (true)
	{
		Console.Clear();
		Console.WriteLine("  \\o/ \n   |  \n  / \\ \n");
		Console.WriteLine("  \\o/ \n   |  \n  / \\ \n");
		Console.WriteLine("  \\o/ \n   |  \n  / \\ \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine("   o/ \n  /|  \n  / \\ \n");
		Console.WriteLine("   o/ \n  /|  \n  / \\ \n");
		Console.WriteLine("   o/ \n  /|  \n  / \\ \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine("  _o/ \n   |  \n  / > \n");
		Console.WriteLine("  _o/ \n   |  \n  / > \n");
		Console.WriteLine("  _o/ \n   |  \n  / > \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine("    o_ \n   /|  \n   / \\ \n");
		Console.WriteLine("    o_ \n   /|  \n   / \\ \n");
		Console.WriteLine("    o_ \n   /|  \n   / \\ \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine(" \\o   \n  |\\  \n / \\  \n");
		Console.WriteLine(" \\o   \n  |\\  \n / \\  \n");
		Console.WriteLine(" \\o   \n  |\\  \n / \\  \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine(" \\o_  \n  |   \n < \\  \n");
		Console.WriteLine(" \\o_  \n  |   \n < \\  \n");
		Console.WriteLine(" \\o_  \n  |   \n < \\  \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine(" _o    \n  |\\   \n / \\   \n");
		Console.WriteLine(" _o    \n  |\\   \n / \\   \n");
		Console.WriteLine(" _o    \n  |\\   \n / \\   \n");
		Thread.Sleep(300);

		Console.Clear();
		Console.WriteLine("  \\o/ \n   |  \n  ~ ~ \n");
		Console.WriteLine("  \\o/ \n   |  \n  ~ ~ \n");
		Console.WriteLine("  \\o/ \n   |  \n  ~ ~ \n");
		Thread.Sleep(300);
	}
}
