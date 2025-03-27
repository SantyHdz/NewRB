# NewRB
Comandos que pueden serme de utilidad
1. git clone URL
   Este comando se utiliza para crear una copia local de un repositorio remoto. La URL puede ser de un repositorio en GitHub, GitLab, Bitbucket, etc. Al clonar, obtienes todo el historial del repositorio, incluyendo todas las ramas.

2. git fetch
   Este comando se utiliza para descargar los cambios de un repositorio remoto sin fusionarlos automáticamente con tu rama actual. git fetch actualiza tu repositorio local con la información más reciente del remoto, pero no modifica tu área de trabajo ni tu rama actual.

3. git pull
   Este comando es una combinación de git fetch y git merge. Descarga los cambios del repositorio remoto y los fusiona automáticamente con tu rama actual. Es útil para mantener tu rama actualizada con los cambios realizados por otros colaboradores.

4. git add *
   Este comando añade todos los archivos en el directorio actual al área de preparación (staging area) para el próximo commit. El asterisco (*) actúa como un comodín que selecciona todos los archivos. Sin embargo, ten cuidado, ya que no añadirá archivos en subdirectorios.

5. git commit -am "Descripcion"
   Este comando realiza un commit de todos los archivos que han sido modificados y que están bajo seguimiento (tracked) en el repositorio. La opción -a añade automáticamente todos los archivos modificados al área de preparación, y -m permite incluir un mensaje de descripción para el commit.

6. git push
   Este comando se utiliza para subir los commits locales a un repositorio remoto. Por defecto, git push sube la rama actual al remoto correspondiente.

7. git branch dev1
   Este comando crea una nueva rama llamada dev1. Sin embargo, no cambia a esa rama; solo la crea.

8. git checkout dev1
   Este comando cambia tu rama actual a dev1. A partir de este momento, cualquier commit que realices se aplicará a la rama dev1.

9. git push -u origin dev1
   Este comando sube la rama dev1 al repositorio remoto y establece origin/dev1 como la rama de seguimiento para dev1. Esto significa que en el futuro, puedes usar simplemente git push o git pull sin especificar la rama.

10. git checkout main
    Este comando cambia tu rama actual a main. Es útil para volver a la rama principal del proyecto.

11. git rebase main
    Este comando se utiliza para aplicar los cambios de la rama actual sobre la última versión de la rama main. Es una forma de integrar cambios de una rama a otra, manteniendo un historial de commits más limpio.

12. Remover si hay error la carpeta rebase-merge en .git
    Si durante un rebase ocurre un error, Git puede dejar una carpeta llamada rebase-merge en el directorio .git. Si decides abortar el rebase, puedes eliminar esta carpeta para limpiar el estado del repositorio.

13. git commit -am "Descripcion"
    Este comando es el mismo que el mencionado anteriormente. Realiza un commit de todos los archivos modificados y bajo seguimiento, añadiendo un mensaje de descripción.

14. git push origin HEAD:main
    Este comando sube los cambios de la rama actual (HEAD) a la rama main en el repositorio remoto origin. Es útil si estás en una rama diferente y quieres enviar tus cambios a main.

15. git checkout -- .
    Este comando descarta todos los cambios no confirmados en el directorio actual, restaurando los archivos a su último estado confirmado. Es útil si deseas deshacer todos los cambios realizados desde el último commit.

16. Remover todo lo de GitHub
    Esto puede referirse a eliminar un reposit|orio de GitHub o a eliminar todos los archivos de un repositorio local. Si deseas eliminar un repositorio de GitHub, puedes hacerlo desde la interfaz web de GitHub. Si deseas eliminar un repositorio local, puedes simplemente borrar la carpeta que contiene el repositorio.

17. Control Panel\User Accounts\Credential Manager
    Esto se refiere a la ubicación en Windows donde se almacenan las credenciales de acceso, como nombres de usuario y contraseñas. Si tienes problemas de autenticación con Git (por ejemplo, al hacer git push), puedes ir al Administrador de Credenciales para eliminar o modificar las credenciales almacenadas.

# Probando

