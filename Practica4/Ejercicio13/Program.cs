/*
Reemplazar estas líneas de código por otras equivalentes que utilicen el operador null-coalescing (?? ) y / o la asignación null-coalescing (??=)

if (st1 == null)
{
    if (st2 == null)
    {
        st = st3;
    }
    else
    {
        st = st2;
    }
}
else
{
    st = st1;
}

if (st4 == null)
{
    st4 = "valor por defecto";
}
*/

string? st="", st1="", st2="", st3="", st4="";

st = st1 ?? (st2 ?? st3); // st = st1 si es != null, sino es st2 si != null, sino es st3

st4 ??= "valor por defecto"; // st4 = st4 si es != null, sino que tome "valor por defecto"
