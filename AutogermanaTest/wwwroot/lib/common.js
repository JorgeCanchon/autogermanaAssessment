const consultCategories = async () => {
    try {
        const response = await fetch('/categories');
        const data = await response.json();
        return data;
    } catch (exception) {
        alert('Ocurrio un error al consultar las categorías');
        console.log(exception);
    }
    return [];
}

const setCategories = async (id) => {
    let categories = await consultCategories();
    let select = document.getElementById(`${id}`);
    categories.forEach(x => {
        let opt1 = document.createElement('option');
        opt1.value = x.id;
        opt1.text = x.nombre;
        select.add(opt1, null);
    });
}
