namespace ProjectFocus.Backend.Service.Identity

open Giraffe

module WebApp =

    let api () =
        choose [
            subRoute "/account"
                (choose [
                    POST >=> choose [
                        route "/login" >=> WebHandler.handleLogin
                    ]
                ])
            setStatusCode 404 >=> text "Not Found" ]
