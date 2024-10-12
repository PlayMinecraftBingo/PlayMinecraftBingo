function SetDarkMode(value)
{
    if (navigator.cookieEnabled)
    {
        document.cookie = "darkmode=" + value + "; path=/;";
        location.reload(true);
    } else {
        alert("Unable to set light/dark mode. Cookies are not enabled.");
    }
}
