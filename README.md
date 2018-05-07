EF6MySqlCodeFirst

Sample project Asp.Net for EntityFramwork 6 Code in First.
Use configuration
	EntityFramwork 				6.x
	MySql.Data					8.0.11.0
	MySql.Data.EntityFramwork	8.0.11.0
	MySql.Web					8.0.11.0
	
Web.config
	<entityFramework>
		<defaultConnectionFactory type="System.Data.Entity.Infrastructure.SqlConnectionFactory, EntityFramework" />
		<providers>
			<provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer" />
		</providers>
	</entityFramework>
	<system.data>
		<DbProviderFactories>
			<remove invariant="MySql.Data.MySqlClient" />
			<add name="MySQLDataProvider" invariant="MySql.Data.MySqlClient" description=".Net Framework Data Provider for MySQL" type="MySql.Data.MySqlClient.MySqlClientFactory, MySql.Data, Version=8.0.11.0, Culture=neutral, PublicKeyToken=c5687fc88969c44d" />
		</DbProviderFactories>
	</system.data>
	<connectionStrings>
		<add name="mydatacs" connectionString="server=localhost;user id=root;password=301114;database=mydata" providerName="MySql.Data.MySqlClient" />
	</connectionStrings>

	