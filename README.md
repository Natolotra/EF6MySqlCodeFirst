EF6MySqlCodeFirst

Sample project Asp.Net for EntityFramwork 6 Code in First.
<hr/>
Use
<ul>
	<li>EntityFramwork  		6.x</li>
  	<li>MySql.Data 			8.0.11.0</li>
  	<li>MySql.Data.EntityFramwork	8.0.11.0</li>
	<li>MySql.Web			8.0.11.0</li>
</ul>
<hr/>
Web.config
<div>
&lt;entityFramework&gt;<br/>
&nbsp;&nbsp;&nbsp; &lt;defaultConnectionFactory type="System.Data.Entity.Infrastructure.SqlConnectionFactory, EntityFramework" /&gt;<br/>
&nbsp;&nbsp;&nbsp; &lt;providers&gt; <br/>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &lt;provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer" /&gt; <br/>
&nbsp;&nbsp;&nbsp; &lt;/providers&gt; <br/>
&lt;/entityFramework&gt;<br/>
&lt;system.data&gt;<br/>
&nbsp;&nbsp;&nbsp; &lt;DbProviderFactories&gt;<br/>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &lt;remove invariant="MySql.Data.MySqlClient" /&gt;<br/>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &lt;add name="MySQLDataProvider" invariant="MySql.Data.MySqlClient" description=".Net Framework Data Provider for MySQL" type="MySql.Data.MySqlClient.MySqlClientFactory, MySql.Data, Version=8.0.11.0, Culture=neutral, PublicKeyToken=c5687fc88969c44d" /&gt;<br/>
&nbsp;&nbsp;&nbsp; &lt;/DbProviderFactories&gt;<br/>
&lt;/system.data&gt;<br/>
&lt;connectionStrings&gt;<br/>
&nbsp;&nbsp;&nbsp; &lt;add name="mydatacs" connectionString="server=localhost;user id=root;password=******;database=mydata" providerName="MySql.Data.MySqlClient" /&gt;<br/>
&lt;/connectionStrings&gt;<br/>
</div>

	
