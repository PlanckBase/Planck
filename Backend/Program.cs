var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string htmlTag = """
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>WireFrame</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <h1>Planck</h1> 
    <h3>An open-source, customizable app for developers to communicate and make changes seamlessly.</h3>
    <hr>
    <h5>MIT License | Copyright (c) 2024 TTheHuman and 5DHD</h5>
</body>
</html>
""";

app.MapGet("/", () => Results.Content(htmlTag, "text/html"));

app.Run();