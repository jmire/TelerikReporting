<!DOCTYPE html>
<html>
<head>
    <title>@ViewBag.Title</title>

    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />

    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>

    @RenderSection("styles", False)
</head>
<body>
    @RenderBody()
    @RenderSection("scripts", False)
</body>
</html>