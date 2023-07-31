<html> 
	<body> 
		<%@ Page aspcompat=true %>
		<%
		Dim conn = Server.CreateObject("ADODB.Connection")
		conn.Open("Provider=SQLOLEDB; Data Source =HBHSSS01\SQLEXPRESS; Initial Catalog = testdb; Integrated Security=SSPI;")
		Dim param1 = request.form("inID")
		Dim param2 = request.form("inData")
		conn.execute("INSERT INTO tblMain values('" & param1 & "','" & param2 & "')")
		Response.Redirect ("page.aspx")
		%>
		Processing ...
	</body> 
</html> 