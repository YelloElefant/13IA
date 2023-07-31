<html> 
	<body> 
		<%@ Page aspcompat=true %>
		<%
			Dim conn = Server.CreateObject("ADODB.Connection")
			conn.Open("Provider=SQLOLEDB; Data Source =HBHSSS01\SQLEXPRESS; Initial Catalog = testdb; Integrated Security=SSPI;")
			If conn.errors.count > 0 Then   
			   Response.Write("SQL Connect Error")
			End If
			Dim rs = conn.execute("SELECT * FROM tblMain")
			%>
		<table>
		   <thead>
			   <tr>
				   <th>Id</th>
				   <th>Data</th>
			   </tr>
		   </thead>
		   <tbody>
			   <%
				Do Until rs.EOF
				Response.Write("<tr>")
				For Each x in rs.Fields
					Response.Write("<td>"& x.value &"</td>")
				Next
				Response.Write("</tr>")
				rs.MoveNext
				Loop
			   %>
		   </tbody>
	   </table>
	   <br>
	   <form method="post" action="insert.aspx">
		  ID <input name="inID" type="number">
		  Data <input name="inData" type="text">
		  <input type="submit">
	   </form>
	</body>
</html>