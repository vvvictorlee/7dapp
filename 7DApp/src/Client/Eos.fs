module Eos

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Import


[<Emit("window.eos")>]
let eos : obj = jsNative

printfn "eos: %A" eos

type Acc = {
    name: string
    privateKey: string
    publicKey: string
}

let accounts = [
  {name = "useraaaaaaaa"; privateKey = "5K7mtrinTFrVTduSxizUc5hjXJEtTjVTsqSHeBHes1Viep86FP5"; publicKey = "EOS6kYgMTCh1iqpq9XGNQbEi8Q6k5GujefN9DSs55dcjVyFAq7B6b"}
  {name = "useraaaaaaab"; privateKey = "5KLqT1UFxVnKRWkjvhFur4sECrPhciuUqsYRihc1p9rxhXQMZBg"; publicKey = "EOS78RuuHNgtmDv9jwAzhxZ9LmC6F295snyQ9eUDQ5YtVHJ1udE6p"}
  {name = "useraaaaaaac"; privateKey = "5K2jun7wohStgiCDSDYjk3eteRH1KaxUQsZTEmTGPH4GS9vVFb7"; publicKey = "EOS5yd9aufDv7MqMquGcQdD6Bfmv6umqSuh9ru3kheDBqbi6vtJ58"}
  {name = "useraaaaaaad"; privateKey = "5KNm1BgaopP9n5NqJDo9rbr49zJFWJTMJheLoLM5b7gjdhqAwCx"; publicKey = "EOS8LoJJUU3dhiFyJ5HmsMiAuNLGc6HMkxF4Etx6pxLRG7FU89x6X"}
  {name = "useraaaaaaae"; privateKey = "5KE2UNPCZX5QepKcLpLXVCLdAw7dBfJFJnuCHhXUf61hPRMtUZg"; publicKey = "EOS7XPiPuL3jbgpfS3FFmjtXK62Th9n2WZdvJb6XLygAghfx1W7Nb"}
  {name = "useraaaaaaaf"; privateKey = "5KaqYiQzKsXXXxVvrG8Q3ECZdQAj2hNcvCgGEubRvvq7CU3LySK"; publicKey = "EOS5btzHW33f9zbhkwjJTYsoyRzXUNstx1Da9X2nTzk8BQztxoP3H"}
  {name = "useraaaaaaag"; privateKey = "5KFyaxQW8L6uXFB6wSgC44EsAbzC7ideyhhQ68tiYfdKQp69xKo"; publicKey = "EOS8Du668rSVDE3KkmhwKkmAyxdBd73B51FKE7SjkKe5YERBULMrw"}
];