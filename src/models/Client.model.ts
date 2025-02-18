import { City } from "./City.model"
import { State } from "./State.model"
import { User } from "./User.model"

export type Client = {
  clientId: number
  userId: number
  user: User
  name: string
  cityId: number
  city: City
  stateId: number
  state: State
  address: string
  createdAt: Date
  updatedAt: Date
}