<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>Conectados actuales - Taller 7</title>
    <script>
        // Base AJAX, Generalización de Carlos Cares
        function ejecutaExterno(id_doc_element, url_php, maximaEspera, sigueFunction) {
            //url_php = encodeURI(url_php);
            let xhttp = new XMLHttpRequest();
            let out = document.getElementById(id_doc_element);
            out.innerHTML = "";
            xhttp.timeout = maximaEspera;
            xhttp.ontimeout = function(e) {
                out.innerHTML = '{"error":"Proceso excede tiempo"}';
            };
            xhttp.onreadystatechange = function() {
                if (this.readyState == 4 && this.status == 200) {
                    out.innerHTML = this.responseText;
                    sigueFunction();
                } else if (this.readyState == 4) {
                    let err =
                        out.innerHTML = '{"error":"inaccesible","status":}' + this.status + '","url":"' + url_php + '"}';
                    sigueFunction();
                }
            };
            xhttp.open("GET", url_php, true);
            xhttp.send();
        }

        function actualizaConectados() {
            let contenido = document.getElementById("conectados").innerHTML;
            let llega = JSON.parse(contenido);
            if (llega.error != "") {
                alert(llega.error);
            } else if (llega.ok == "yes") {
                muestraConectados(llega.conectados);
            }
            return;
        }

        function muestraConectados(conectado) {
            let tabla = document.createElement("table");
            let fila = document.createElement("tr");
            fila.id = "encabezado";
            let celda = document.createElement("td");

            // Encabezado 1
            celda.innerHTML = "Conectado";
            fila.appendChild(celda);

            // Encabezado 2
            celda = document.createElement("td");
            celda.innerHTML = "Color";
            celda.width = "20%";
            fila.appendChild(celda);

            // Envabezado 3
            celda = document.createElement("td");
            celda.align = "center";
            let boton = document.createElement("input");
            boton.type = "button";
            boton.value = "Nuevo";
            boton.setAttribute("onclick", "botonNuevo()");
            celda.appendChild(boton);
            fila.appendChild(celda);

            tabla.appendChild(fila);

            for (let k = 0; k < conectado.length; k++) {
                fila = document.createElement("tr");
                fila.id = "fila" + (k + 1);
                celda = document.createElement("td");

                // Columna con el nombre
                celda.innerHTML = conectado[k].nombre;
                fila.appendChild(celda);

                // Columna con el color
                celda = document.createElement("td");
                celda.style.backgroundColor = "#" + conectado[k].color;
                fila.appendChild(celda);

                // Columna con el botón X (y nuevo)
                celda = document.createElement("td");
                celda.align = "center";
                let boton = document.createElement("input");
                boton.type = "button";
                boton.value = "X";
                boton.setAttribute("onclick", "indicarFila(" + (k + 1) + ")");
                celda.appendChild(boton);
                fila.appendChild(celda);

                tabla.appendChild(fila);
            }

            let div = document.getElementById("salidavisible");
            div.innerHTML = "";
            div.appendChild(tabla);
        }

        function actualizaConectadosRecurrentemente(tiempo) {
            let url = "conectados.php?accion=todos&hora=" + (new Date()).getTime();

            // Aquí se muestra la nueva invocación del método
            console.log("Nueva invocación: " + url)

            ejecutaExterno("conectados", url, 2000, actualizaConectados);
            setTimeout(actualizaConectadosRecurrentemente, tiempo, tiempo);
        }

        function botonNuevo() {
            alert("Se ha presionado el botón Nuevo");
        }

        function indicarFila(fila) {
            alert("Se hizo click en la fila " + fila);
        }
    </script>
    <style>
        table, th, td {
            border: 1px solid black;
            border-collapse: collapse;
        }
    </style>
</head>

<body>
    <h3>Conectados</h3>
    <div id="conectados" style="display:none"></div>
    <div id="salidavisible"></div>
    <script>
        actualizaConectadosRecurrentemente(5000);
    </script>
</body>

</html>