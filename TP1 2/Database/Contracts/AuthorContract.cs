using System;
namespace TP1.Database.Contracts
{
    public static class AuthorContract
    {
        public const String USER_TABLE = "author";
        public const String USER_ID = "id";
        public const String USER_FIRSTNAME = "firstname";
        public const String USER_LASTNAME = "lastname";

        public const String DATABASE_NAME_CONCAT = "_";

        public const String USER_COLUM_ID = USER_TABLE + DATABASE_NAME_CONCAT + USER_ID;
        public const String USER_COLUM_NAME = USER_TABLE + DATABASE_NAME_CONCAT + USER_FIRSTNAME;
        public const String USER_COLUM_NB_PAGE = USER_TABLE + DATABASE_NAME_CONCAT + USER_LASTNAME;
    }
}
