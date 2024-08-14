@Code
    ViewData("Title") = "WithYouWithMe"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title")</h2>
    @*<h3>@ViewData("Message")</h3>*@

    <address>
        114 Cobble Lane<br />
        London N1 2EF<br />
        @*<abbr title="Contact">P:</abbr>*@        
    </address>
    <address>
        @*<strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />*@
        <strong>Contact:</strong> <a href="mailto:contact@withyouwithme.com">contact@withyouwithme.com</a>       
    </address>
</main>