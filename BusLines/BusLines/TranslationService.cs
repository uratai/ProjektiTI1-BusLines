//using BusLines.BO;
//using BusLines.DAL;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusLines
//{
//	public class TranslationService
//	{
//	}
//}
////		//List of translations
////		public static List<Translations> Translations = new List<Translations>();
////		//Selected language
////		public static LanguageEnum SelectedLanguage = LanguageEnum.Albanian;

////		public static void LoadTranslations()
////		{
////			//get all translations from database
////			DataTable results = TranslationsDAL.GetAllTranslations();
////			//for every item of data row in result add new item in list of Translations
////			foreach (DataRow item in results.Rows)
////			{
////				Translations.Add(new Translations()
////				{
////					TranslationKey = item.Field<string>("TranslationKey"),
////					English = item.Field<string>("English"),
////					Albanian = item.Field<string>("Albanian")
////				});
////			}
////		}

////	}
////}


	