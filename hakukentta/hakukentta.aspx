<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Satamavahti.WebForm" %>

<!DOCTYPE html>
<html lang="fi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Satamavahti</title>
    <link rel="stylesheet" href="StyleSheet1.css">
</head>
<body>
    <h1>Satamavahti</h1>
    <form id="satamaForm" runat="server" method="post">
        <label for="satama">Valitse satama:</label>
        <select id="satama" name="satama" runat="server">
            <option value="hanko">Hanko</option>
            <option value="helsinki">Helsinki</option>
            <option value="inkoo">Inkoo</option>
            <option value="kotka-hamina">Kotka-Hamina</option>
            <option value="loviisa">Loviisa</option>
            <option value="sköldvik">Sköldvik</option>
        </select>
        <br><br>

        <label for="laiva">Valitse laiva:</label>
        <select id="laiva" name="laiva" runat="server">
            <option value="purjelaiva">Purjelaiva</option>
            <option value="soutuvene">Soutuvene</option>
            <option value="moottorivene">Moottorivene</option>
            <option value="kanootti">Kanootti</option>
        </select>
        <br><br>

        <button type="submit" id="Button1">Näytä tiedot</button>
    </form>

    <div id="laivaTiedot">
        <strong>Valitsemasi tiedot:</strong>
        <p id="tulos"><%= Tiedot %></p>
    </div>
</body>
</html>