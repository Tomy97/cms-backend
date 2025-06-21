import { City } from "./City.model"
import { State } from "./State.model"
import { User } from "./User.model"

export type Client = {
  id: number
  userId: number
  cityId: number
  stateId: number
  name: string
  address: string
  city: City
  user: User
  state: State
  createdAt: Date
  updatedAt: Date
}