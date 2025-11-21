using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
	public partial class Form1 : Form
	{
		void DIÁK_ROBOTJAI()
		{
			Robot.Get("Karesz").Feladat = delegate ()
			{
			
			};
		}
    }
}





/* USERS MANUAL -- LEGFONTOSABB PARANCSOK

MOZGÁSOK

Lépj();                          -------- Karesz előre lép egyszer.
Fordulj(jobbra);                 -------- Karesz jobbra fordul.
Fordulj(balra);                  -------- Karesz balra fordul.
Vegyél_fel_egy_kavicsot();       -------- Karesz felvesz egy kavicsot.
Tegyél_le_egy_kavicsot();        -------- Karesz letesz egy fekete kavicsot
Tegyél_le_egy_kavicsot(piros);   -------- Karesz letesz egy piros kavicsot.

Minden mozgás után a robot köre véget ér és a következő robot jön. 

SZENZOROK

Van_e_előttem_fal();        -------- igaz, ha Karesz fal előtt áll, egyébként hamis.
Kilépek_e_a_pályáról();     -------- igaz, ha Karesz a pálya szélén kifele néz, egyébként hamis.
Van_e_itt_Kavics();         -------- igaz, ha Karesz épp kavicson áll, egyébként hamis.
Köveinek_száma_ebből(piros) -------- Karesz piros köveinek a száma.
Mi_van_alattam();           -------- a kavics színe, amin Karesz áll. (Ez igazából egy szám!)
Ultrahang();                -------- a Karesz előtt található tárgy távolsága. Ez a tárgy lehet fal vagy másik robot is. 
SzélesUltrahang();          -------- ugyanaz, mint az ultrahangszenzor, de ez nem csak a Karesz előtti mezőket pásztázza, hanem a szomszédos mezőket is. Egy számhármast ad vissza. 
Hőmérséklet();              -------- a Karesz által mért hőmérséklet. A láva forrása 1000 fok, amitől lépésenként távolodva a hőmérséklet 200 fokonként hűl. Az alapértelmezett hőmérséklet 0 fok.

#####################################################
													#
00000		00000	0   0	0   0	 0000	 0000	#
   0		0		0   0	00  0	0		0		#
  0			000		0   0	0 0 0	0		00000	#
 0			0		0   0	0  00	0		    0	#
00000		0		 000	0   0	 0000	0000	#
													#
#####################################################

Mozgás:

ZNézz(fel/le/balra/jobbra)       -------- Karesz néz egy megadott irányba.
ZLépj(n);                        -------- Karesz előre lép n-szer.
ZSétálj();					   	 -------- Karesz lép előre addig, ameddig falhoz vagy a pálya széléhez nem ér.
ZMondd(ezt);					 -------- Karesz kimondja azt, amit megadsz a zárójelekben.
ZLőjj();						 -------- Karesz lő egy hógolyót, ha tud.
ZVárj(ennyit);					 -------- Karesz vár ennyi iterációt.

Érzékelés:

ZPozíció();					     -------- Visszaadja Karesz X és Y pozícióját egy listában (X,Y).
ZVan_e_előttem_kavics(x)		 -------- Igaz ha Karez előtt van x típusú kavics.

A szenzorokat bármennyiszer használhatja a robot a saját körén belül.
*/