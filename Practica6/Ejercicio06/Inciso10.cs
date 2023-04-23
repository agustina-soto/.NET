class A
{
    private int Prop
    { set; public get; }
}


class B : A
{
}

/*
    Los descriptores de acceso (get-set) pueden tener distintos niveles de accesibilidad, pero el modificador del accessor debe ser más restrictivo que el de la propiedad.
    El descriptor de acceso de lectura se definio como public mientras que el de la propiedad se declaro como private.
*/
