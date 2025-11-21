using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karesz
{
	partial class Form1
	{
		#region Robotokra visszavezetett parancsok

		//void ZVárj(int n = 1)
		//{ for (int i = 0; i < n; i++) Robot.akit_kiválasztottak.Várj(); }
		//void ZLépj(int n = 1)
		//{ if (!legacy_mode) Robot.akit_kiválasztottak.Lépj(n); }
		void Lépj() =>
			Robot.akit_kiválasztottak.Lépj(1);
		//void ZSétálj()
		//{ if (!legacy_mode) Robot.akit_kiválasztottak.Sétálj(); }
		void Fordulj(int irány) =>
			Robot.akit_kiválasztottak.Fordulj(irány);
		//void ZNézz(int dir)
		//{ if (!legacy_mode) Robot.akit_kiválasztottak.Nézz(dir); }
		int Köveinek_száma_ebből(int szín) =>
			Robot.akit_kiválasztottak.Köveinek_száma_ebből(szín);
		void Vegyél_fel_egy_kavicsot() =>
			Robot.akit_kiválasztottak.Vegyél_fel_egy_kavicsot();
		void Tegyél_le_egy_kavicsot(int szín = fekete) =>
			Robot.akit_kiválasztottak.Tegyél_le_egy_kavicsot(szín);
		//void ZMondd(string ezt)
		//{ if (!legacy_mode) Robot.akit_kiválasztottak.Mondd(ezt); }
		//void ZLőjj()
		//{ if (!legacy_mode) Robot.akit_kiválasztottak.Lőjj(); }
		bool Van_e_itt_Kavics() =>
			Robot.akit_kiválasztottak.Alatt_van_kavics();
		int Mi_van_alattam() =>
			Robot.akit_kiválasztottak.Alatt_ez_van();
		bool Van_e_előttem_fal() =>
			Robot.akit_kiválasztottak.Előtt_fal_van();
		bool Kilépek_e_a_pályáról() =>
			Robot.akit_kiválasztottak.Ki_fog_lépni_a_pályáról();
		//bool ZVan_e_előttem_kavics(int type = fekete) =>
		//	Robot.akit_kiválasztottak.MiVanElőttem() == type;
        int Ultrahang() =>
			Robot.akit_kiválasztottak.UltrahangSzenzor();
		(int, int, int) SzélesUltrahang() =>
			Robot.akit_kiválasztottak.SzélesUltrahangSzenzor();
		int Hőmérséklet() =>
			Robot.akit_kiválasztottak.Hőmérő();
		//(int, int) ZPozíció() =>
		//	Robot.akit_kiválasztottak.Hol_vagyok();

        #endregion

        #region Pályára visszavezetett parancsok

        void Betölt(string path) => pálya.Betölt(path);

        #endregion
	}
}
