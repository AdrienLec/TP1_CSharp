using System;
namespace TP1.Database.Contracts
{
    public static class BookContract
    {
        public const String USER_TABLE = "book";
        public const String USER_ID = "id";
        public const String USER_NAME = "name";
        public const String USER_NB_PAGE = "nb_page";

        public const String DATABASE_NAME_CONCAT = "_";

        public const String USER_COLUM_ID = USER_TABLE + DATABASE_NAME_CONCAT + USER_ID;
        public const String USER_COLUM_NAME = USER_TABLE + DATABASE_NAME_CONCAT + USER_NAME;
        public const String USER_COLUM_NB_PAGE = USER_TABLE + DATABASE_NAME_CONCAT + USER_NB_PAGE;

     }
}
