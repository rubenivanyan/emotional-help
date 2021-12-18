import {
  mockedConsultingApplications,
} from '../common/mocks/consulting-applications';
import { apiFetchGet } from './fetch';

export const getConsultingApplications = async () => {
  const consultingApplication = await apiFetchGet('/api/consultingApplication')
    .then((response) => response.json());
  return consultingApplication.length ?
    consultingApplication :
    mockedConsultingApplications;
};
