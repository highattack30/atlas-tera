﻿using FluentNHibernate.Mapping;

namespace GameServer.Model.Mappings.Accounts
{
    public class AccountMap : ClassMap<Account.Account>
    {
        public AccountMap()
        {
            Table("Accounts");

            Id(x => x.Id);
            Map(x => x.Name)
              .Length(20)
              .Not.Nullable();
            Map(x => x.Password)
              .Length(32)
              .Not.Nullable();
            Map(x => x.AccountLevel).CustomType<int>();
            Map(x => x.Token)
              .Length(50)
              .Nullable();
        }
    }
}